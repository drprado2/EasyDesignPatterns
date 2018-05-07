echo comeceiODeploy
sudo echo echoComSudo
tar -czf - ./docker-compose.yml | ssh -i "deploy_rsa" -o UserKnownHostsFile=/dev/null -o StrictHostKeyChecking=no  $AWS_MACHINE "tar -xzf - -C /easy-design-patterns"
echo passeiDaParteDecopiarArquivo
ssh -i "deploy_rsa" -tt -o UserKnownHostsFile=/dev/null -o StrictHostKeyChecking=no $AWS_MACHINE <<EOF
	cd /easy-design-patterns/
	docker-compose down --rmi all -v
	docker-compose up -d
	exit
EOF
echo chegueiNoFim
