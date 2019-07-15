app.service("fileManagement",
    [
        "$http", function ($http) {
            this.uploadFileToUrl = function (file, fileName, fileDescription, uploadUrl) {
                var fd = new FormData();
                fd.append("file", file);
                fd.append("name", fileName);
                fd.append("description", fileDescription);

                var response = $http.put(uploadUrl,
                    fd,
                    {
                        transformRequest: angular.identity,
                        headers: { 'Content-Type': undefined }
                    }).then(function (response) {
                        return response.data;
                    });

                return response;
            }

            this.getFilesFromUrl = function (filesUrl) {
                var response = $http.get(filesUrl)
                    .then(function (response) {
                        return response.data;
                    });
                return response;
            }
        }
    ]);