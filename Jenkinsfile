pipeline {
  agent {
    docker {
      image 'node:6-alpine'
      args '-p 3000:3000'
    }

  }
  stages {
    stage('bulid') {
      steps {
        sh 'python -m py_compile sources/add2vals.py sources/calc.py'
      }
    }

  }
}