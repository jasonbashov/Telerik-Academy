/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\09.jQuery Overview\jQueryOverview\jQueryOverview\libraries/jquery-2.1.1.js" />
(function () {
    var $tableContainer = $('#table-container'),
        $genTableBtn = $('#gen-table'),
        students = [{
            firstName: 'Peter',
            lastName: 'Ivanov',
            grade: 3
        }, {
            firstName: 'Milena',
            lastName: 'Grigorova',
            grade: 6
        }, {
            firstName: 'Gergana',
            lastName: 'Borisova',
            grade: 12 
        }, {          
            firstName: 'Boyko',
            lastName: 'Petrov',
            grade: 7
        }];
    $genTableBtn.on('click', onGenerateTableBtnClick);
    $('table').append(tableHeaderFrame());
    function tableHeaderFrame() {
        return $('<thead><tr><td>First name</td><td>Last name</td><td>Grade</td></tr></thead>');
    }

    function tableRowFrame(fName, lName, grade) {
        return $('<tr><td>' + fName + '</td><td>' + lName + '</td><td>' + grade + '</td></tr>');
    }

    function onGenerateTableBtnClick() {
        for (var i in students) {
            $('table').append(tableRowFrame(students[i].firstName, students[i].lastName, students[i].grade));
        }
    }
}());