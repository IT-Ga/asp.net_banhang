﻿function doSearch(page) {
    var url = $("#searchInput").prop("action");
    var input = $("#searchInput").serializeArray();
    input.push({ "name": "page", "value": page });
    $.ajax({
        type: "POST",
        url: url,
        data: input,
        error: function () {
            alert("Your request is not a valid!");
        },
        success: function (data) {
            $("#searchResult").html(data);
        }
    });
}

