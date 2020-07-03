
$(document).ready(function () {
    var eplofileJS = new EProfileJS();
})

class EProfileJS {
    constructor() {
        this.loadData();
        this.inintEvents();
    }
    loadData() {
        alert(1);
    }

    /**
     * Hàm định dạng tiền tệ
     * @param {number} value tiền
     */
    formatMoney(value) {

    }

    /**
     * Khởi tạo các event trong page
     * Author: NVMANH (02/07/2020)
     * */
    inintEvents() {
        $("#buttonSave").click(this.saveData);
        $("#buttonCancel").click(this.saveData);
    }

    /**
     * 
     * 
     * */
    saveData() {

    }

}
