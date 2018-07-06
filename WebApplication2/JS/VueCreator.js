var VueCreator = {};

VueCreator.GetEmptyOption = function () {
    var option = {
        template: "模板ID或html",
        targetId: "默认容器ID",
        data:"需要绑定的数据"
    };
}

VueCreator.ShowListTo = function (url,requesData,option) {

    var vueData = {};
    var inst = new Vue(vueData);
}

VueCreator.ShowFormTo = function (url, requesData,option) {

}

VueCreator.ShowContentTo = function (url, requesData,option) {
    var vueData = {};
    vueData.el = "#app1";
    vueData.data = {
        message: "显示的数据",
        seen: true,
        todos: [
            { text: '学习 JavaScript' },
            { text: '学习 Vue' },
            { text: '整个牛项目' }
        ]
    };
    var inst = new Vue(vueData);
}