// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function submitSearchForm(event,url) {
    event.preventDefault();

    const resultTable = document.getElementById('result');
    const input = document.getElementById('search');

    $.post(url + '?search=' + input.value, result => resultTable.innerHTML = result);
}