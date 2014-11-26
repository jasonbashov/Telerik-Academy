define(function myfunction() {
    var people = [{
        id: 1,
        name: "Николай Костов",
        avatarUrl: "images/niki.jpg",
        age: 24,
    }, {
        id: 2,
        name: "Ивайло Кенов",
        avatarUrl: "images/ivo.jpg",
        age: 25,
    }, {
        id: 3,
        name: "Дончо Минков",
        avatarUrl: "images/doncho.jpg",
        age: 26
    }, {
        id: 4,
        name: "Тодор Стоянов",
        avatarUrl: "images/todor.jpg",
        age: 25,
    }];

    var authors = [{
        name: "Николай Костов",
        image: "images/niki.jpg",
        titles: ["Technical <b>Trainer</b>", "Rapper"],
        urls: ["http://nikolay.it", "https://github.com/NikolayIT"],
    }, {
        name: "Ивайло Кенов",
        image: "images/ivo.jpg",
        titles: ["Technical <b>Trainer</b>", "Rapper"],
        urls: ["http://ivaylo.bgcoder.com", "https://github.com/ivaylokenov"],
    }, {
        name: "Дончо Минков",
        image: "images/doncho.jpg",
        titles: ["Technical <b>Trainer</b>"],
        urls: ["http://minkov.it", "https://github.com/Minkov"],
    }, {
        id: 4,
        name: "Тодор Стоянов",
        image: "images/todor.jpg",
        titles: ["Software <b>Developer</b>"],
        urls: ["https://github.com/todorstoianov"],
    }];

    return authors;
});