$(function () {
    'use strict';
    // Declare a proxy to reference the hub. 
    var hub = $.connection.complexTypeHub;

    // Create a function that the hub can call to broadcast messages.
    hub.client.getAnimals = animalAction;

    // Start the connection.
    $.connection.hub.start().done(hubDone);

    //functions
    function animalAction(animal) {
        for (let i = 0; i < animal.length; i++) {
            $('#listAnimals').append('<li><strong>Name: </strong>' + animal[i].Name + ' <br><strong>Number Of Legs: </strong>' + animal[i].NumberOfLegs + '</li>');
        }
    };

    function hubDone() {
        console.log('hub connection established.');

        // Call the Send method on the hub.
        hub.server.listAnimals();
        hub.server.superList().then(animalAction);
    };
});