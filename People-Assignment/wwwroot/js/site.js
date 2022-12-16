
function getPeopleListAjax(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("Response:", response);
        document.getElementById("result").innerHTML = response;
    });
}

function submitSearchForm(event, url) {
    event.preventDefault();

    const resultTable = document.getElementById('result');
    const input = document.getElementById('search');

    console.log(result);
    $.post(url + '?search=' + input.value, result => resultTable.innerHTML = result);
}

function ajaxPost(actionUrl, personID) {

    let inputElement = $("#" + personID);
    let data = {
        [inputElement.attr("name")]: inputElement.val()
    }
    console.log("inputEl:", inputElement);
    console.log("data: ", data);
    $.post(actionUrl, data, function (respons) {
        console.log("Respons", respons);
        document.getElementById("result").innerHTML = respons;
    })
}
