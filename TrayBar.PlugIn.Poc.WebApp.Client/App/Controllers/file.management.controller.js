app.controller("fileManagementController",
    [
        "$scope", "fileManagement", function($scope, fileManagement) {
            $scope.uploadFile = function() {
                var file = $scope.myFile;
                var fileName = $scope.fileName;
                var fileDescription = $scope.fileDescription;
                if (!$scope.portNumber) {
                    alert("Please select the port number of the Web Api");
                }
                if (!file || !fileName || !fileDescription) {
                    alert("Please complete the file name, description and attach file");
                }
                var uploadUrl = "http://localhost:" + $scope.portNumber + "/SignDocument";
                $scope.fileNameResponse = fileManagement.uploadFileToUrl(file, fileName, fileDescription, uploadUrl)
                    .then(function (data) {
                        $scope.fileNameResponse = data;
                    });
            };

            $scope.getData = function() {
                if (!$scope.portNumber) {
                    alert("Please select the port number of the Web Api");
                }

                var filesUrl = "http://localhost:" + $scope.portNumber + "/GetDocuments";
                $scope.documents =
                    fileManagement.getFilesFromUrl(filesUrl).then(function(data) {
                        $scope.documents = data;
                    });
            };

        }
    ]);