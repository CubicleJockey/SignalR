$(function () {
    // Declare a proxy to reference the hub. 
    var chat = $.connection.chat;

    // Create a function that the hub can call to broadcast messages.
    chat.client.sendMessageToPage = sendMessage;

    // Get the user name and store it to prepend to messages.
    $('#displayname').val(prompt('Enter your name:', ''));
    // Set initial focus to message input box.  
    $('#message').focus();


    // Start the connection.
    $.connection.hub.start().done(hubDone);

    //functions

    function sendMessage(name, message) {
        // Html encode display name and message. 
        var encodedName = $('<div />').text(name).html();
        var encodedMsg = $('<div />').text(message).html();
        // Add the message to the page. 
        $('#discussion').append('<li><strong>' + encodedName
            + '</strong>:&nbsp;&nbsp;' + encodedMsg + '</li>');
    };

    function hubDone() {
        $('#sendmessage').click(function () {
            // Call the Send method on the hub. 
            chat.server.send($('#displayname').val(), $('#message').val());
            // Clear text box and reset focus for next comment. 
            $('#message').val('').focus();
        });
    }
});