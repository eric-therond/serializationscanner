const fs = require('fs');

function fromString(input) {
    var results = [];

    const regexpcsharp = new RegExp("AAEAAAD|H4sI|__type",'g');
    const regexpjava = new RegExp("[B@2|rO0A|[B@5",'g');
    
    
    if(regexpcsharp.test(input)) {
        results.push("csharp serialized object found");
    }
    
    if(regexpjava.test("java serialized object found")) {
        
    }
    
    return JSON.stringify(results);
} 

module.exports.fromString = fromString;

