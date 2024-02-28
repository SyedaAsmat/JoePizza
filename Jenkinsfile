pipeline {
    agent any
    
    stages {
        stage('Test') {
            steps {
                // Checkout the source code from GitHub
                git 'https://github.com/SyedaAsmat/JoePizza.git'
                
                // Run tests
                bat 'dotnet test --logger "trx;LogFileName=test_results.trx"'
            }
        }
    }
}
