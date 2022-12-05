function extractFile(filePath) {

    let splitPath = filePath.split('\\');
    splitPath = splitPath.pop();
    splitPath = splitPath.split('.');

    console.log(`File name: ${splitPath[0]}`);
    console.log(`File extension: ${splitPath[1]}`);
}

extractFile('C:\\Internal\\training-internal\\Template.pptx');
extractFile('C:\\Projects\\Data-Structures\\LinkedList.cs');