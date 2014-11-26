(function () {
    function onBtnClick() {
        var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net",
                    ".net", "css", "wordpress", "xaml", "js", "http",
                    "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp",
                    "javascript", "js", "cms", "html", "javascript",
                    "http", "http", "CMS"],
            tagCloud = generateTagCloud(tags, 17, 42);

        document.body.appendChild(tagCloud);

        function generateTagCloud(text, minFont, maxFont) {
            div = document.createElement("div");
            var wordsCount = countWords(text);

            div.style.width = "300px";
            div.style.border = "1px solid black";

            var min = Number.MAX_VALUE;
            var max = 0;

            for (var word in wordsCount) {
                if (wordsCount[word] > max) {
                    max = wordsCount[word];
                }
                if (wordsCount[word] < min) {
                    min = wordsCount[word];
                }
            }

            for (var w in wordsCount) {
                var span = document.createElement("span");

                if (min === wordsCount[w]) {
                    span.style.fontSize = minFont + "px";
                }
                else if (max === wordsCount[w]) {
                    span.style.fontSize = maxFont + "px";
                }
                else {
                    span.style.fontSize = minFont + ((maxFont - minFont) / ((max - wordsCount[w]) + 1)) + "px";
                }
                span.innerText = w + " ";
                div.appendChild(span);
            }

            function countWords(passedTags) {
                var obj = {};
                for (var i in passedTags) {
                    passedTags[i] = passedTags[i].toLowerCase();

                    if (obj[passedTags[i]] === undefined) {
                        obj[passedTags[i]] = 1;
                    } else {
                        obj[passedTags[i]]++;
                    }
                }
                return obj;
            }

            return div;
        }
    }
    var createCloudBtn = document.getElementById("btn-create-cloud");
    createCloudBtn.addEventListener("click", onBtnClick);
}());