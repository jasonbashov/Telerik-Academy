﻿(function () {
    'use strict';
    require(['httpRequestModule'], function (httpRequest) {
        var headerOptions = {
            contentType: 'application/json',
            accept: 'application/json',
        };
        var firstStudent = {
            name: "Gosho",
            grade: 1
        };
        var secondStudent = {
            name: "Pesho",
            grade: 2
        };
        var thirdStudent = {
            name: "Stamat",
            grade: 3
        };

        httpRequest.postJSON("http://localhost:3000/students", firstStudent, headerOptions)
            .then(httpRequest.postJSON("http://localhost:3000/students", secondStudent, headerOptions))
            .then(httpRequest.postJSON("http://localhost:3000/students", thirdStudent, headerOptions));
        httpRequest.getJSON("http://localhost:3000/students", headerOptions)
            .then(function (data) {
                var list,
                    i,
                    len,
                    student,
                    jsonData,
                    item;
                list = document.createElement('ul');
                jsonData = JSON.parse(data);
                len = jsonData.count;
                for (i = 0; i < len; i += 1) {
                    student = jsonData.students[i];
                    item = document.createElement('li');
                    item.innerHTML = student.name + ' is in ' + student.grade + ' grade';
                    list.appendChild(item);
                }
                document.getElementById('http-response').appendChild(list);
            }, function (err) {
                document.getElementById("http-response").innerHTML = "<div style='color:red;font-weight:bold'>Error</div>";
            });
    });
}());