var words = ["isc", "is", "cat", "swimming", "in", "the", "pool", "other", "hi"];

var phrase = "iscatswimminginthepool";

function isAllWordsInPhrase(words, phrase) {
    for (var i = 0; i < words.length; i++) {

        if (phrase.length) {
            for (var i = 0; i < words.length; i++) {
                var word = words[i];
                phrase = phrase.replace(word, "");
            }
        }

        return phrase.trim().length === 0;
    }
}

function canBuildPhrase(words, phrase) {
    var startEl = "";
    var result = false;
    while (!result || (!result && startEl !== words[0])) {
        console.log("startEl: " + words[0]);
        result = isAllWordsInPhrase(words, phrase);
        startEl = words.shift();
        words.push(startEl);
    }
    return result;
}

console.log("Can Build phrase");
console.log(canBuildPhrase(words, phrase));
