function addToReadList(bookId) {
    $.ajax({
        url: "/Home/AddToReadList?bookId=" + bookId,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#book-' + bookId)[0].text = 'Remove from read books';
            $('#book-' + bookId).attr('onclick', 'removeFromReadList(' + bookId + ')');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

function removeFromReadList(bookId) {
    $.ajax({
        url: "/Home/RemoveFromReadList?bookId=" + bookId,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#book-' + bookId)[0].text = 'Add to read books'
            $('#book-' + bookId).attr('onclick', 'addToReadList(' + bookId + ')');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}  