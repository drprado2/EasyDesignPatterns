DOCKER_ENV=''
DOCKER_TAG=''

case "$TRAVIS_BRANCH" in
  "master")
    DOCKER_ENV=production
    DOCKER_TAG=latest
    ;;
  "develop")
    DOCKER_ENV=development
    DOCKER_TAG=dev
    ;;    
esac

if [ "${TRAVIS_PULL_REQUEST}" = "false" ]; then
	docker login -u $DOCKER_USERNAME -p $DOCKER_PASSWORD

	docker build -f ./src/EasyDesignPatterns.API/Dockerfile.$DOCKER_ENV -t easy-design-patterns-api:$DOCKER_TAG ./src/EasyDesignPatterns.API --no-cache
	docker build -f ./src/EasyDesignPatterns.UI/Dockerfile.$DOCKER_ENV -t easy-design-patterns-ui:$DOCKER_TAG ./src/EasyDesignPatterns.UI --no-cache

	docker tag easy-design-patterns-api:$DOCKER_TAG $DOCKER_USERNAME/easy-design-patterns-api:$DOCKER_TAG
	docker tag easy-design-patterns-ui:$DOCKER_TAG $DOCKER_USERNAME/easy-design-patterns-ui:$DOCKER_TAG

	docker push $DOCKER_USERNAME/easy-design-patterns-api:$DOCKER_TAG
	docker push $DOCKER_USERNAME/easy-design-patterns-ui:$DOCKER_TAG
fi

