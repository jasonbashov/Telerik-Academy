/// <reference path="D:\Telerik\JavaScript\JavaScript UI and DOM\Homework\09.jQuery Overview\jQueryOverview\jQueryOverview\libraries/jquery-2.1.1.js" />
(function () {
    var firsCellData,
        secondCellData,
        thirdCellData,
        addNewRowButton = $('.btnRowAdd'),
        addHeaderButton = $('.btnHeaderAdd'),
        addNewGridButton = $('.btnGridAdd');

    addNewRowButton.on('click', addRow);
    addHeaderButton.on('click', addHeader);
    addNewGridButton.on('click', addNewGrid);

    function addNewGrid() {
        $this = $(this);
        $this.off('click');
        //console.log($this.next());
        $this.next().append(newGridTemplate());

        $this.next().find('.btnRowAdd').on('click', addRow);
        $this.next().find('.btnGridAdd').on('click', addNewGrid);
        //console.log($this.next().find('.btnHeaderAdd').html());
        //$this.next().next().find('.btnHeaderAdd').on('click', addInnerHeader);
        $this.next().find('.btnHeaderAdd').on('click', addInnerHeader);
    }

    function addRow() {
        $this = $(this);
        getValues($this);
        $this.next().next().next().append(tableRowFrame(firsCellData, secondCellData, thirdCellData));
        //we attach events to the new buttons
        $this.find('.btnRowAdd').on('click', addRow);
        $this.find('.btnGridAdd').on('click', addNewGrid);
        $this.find('.btnHeaderAdd').on('click', addHeader);

    }

    function newGridTemplate() {
        return ('<tr><td colspan="3"><div><div><input ' +
                'type="text" class="firstCell" placeholder="first cell" />' +
                '<input type="text" class="secondCell" placeholder="second cell" />' +
                '<input type="text" class="thirdCell" placeholder="third cell" /></div>' +
                '<button class="btnRowAdd">Add new row</button><button class="btnHeaderAdd">' +
                'Add HHHH</button><button class="btnGridAdd">Add new GridView</button>' +
                '<table id=""><thead class="fatherHeader"></thead></table></div></td></tr>');
    }
    function addHeader() {
        $this = $(this);
        getValues();
        $('#fatherHeader').empty().append(tableHeaderFrame(firsCellData, secondCellData, thirdCellData));
    };

    function addInnerHeader() {
        $this = $(this);
        //console.log($this.next.next());
        firsCellData = $this.prev().prev().find('.firstCell').val();
        secondCellData = $this.prev().prev().find('.secondCell').val();
        thirdCellData = $this.prev().prev().find('.thirdCell').val();
        $this.next().next().find('.fatherHeader').empty().append(tableHeaderFrame(firsCellData, secondCellData, thirdCellData));
    };

    function tableRowFrame(firstCellVal, secondCellVal, thirdCellVal) {
        return $('<tr><td>' + firstCellVal + '</td><td>' + secondCellVal + '</td><td>' + thirdCellVal + '</td></tr>');
    }

    function tableHeaderFrame(firstCellVal, secondCellVal, thirdCellVal) {
        return $('<tr><th>' + firstCellVal + '</th><th>' + secondCellVal + '</th><th>' + thirdCellVal + '</th></tr>');
    }

    function getValues($this) {
        //console.log($this.prev().html());
        if ($this) {
            firsCellData = $this.prev().find('.firstCell').val();
            secondCellData = $this.prev().find('.secondCell').val();
            thirdCellData = $this.prev().find('.thirdCell').val();
        }
        else {
            firsCellData = $('.firstCell').val();
            secondCellData = $('.secondCell').val();
            thirdCellData = $('.thirdCell').val();
        }
    }
}());