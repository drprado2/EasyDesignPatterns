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

	docker image build -f ./src/EasyDesignPatterns.UI/Dockerfile -t easy-design-patterns-ui:$DOCKER_TAG . --no-cache

	docker tag easy-design-patterns-ui:$DOCKER_TAG $DOCKER_USERNAME/easy-design-patterns-ui:$DOCKER_TAG

	docker push $DOCKER_USERNAME/easy-design-patterns-ui:$DOCKER_TAG
fi

