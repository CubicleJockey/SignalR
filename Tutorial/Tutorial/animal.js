$(function () {
    // Declare a proxy to reference the hub. 
    var hub = $.connection.animal;

    var animals = hub.server.showAnimals().done(consoleLogAnimals);


    function consoleLogAnimals(animal) {
        console.log(animal);
    }

    // Start the connection.
    $.connection.hub.start().done();
});