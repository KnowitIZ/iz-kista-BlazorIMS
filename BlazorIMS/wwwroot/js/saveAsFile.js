//https://stackoverflow.com/questions/4212861/what-is-a-correct-mime-type-for-docx-pptx-etc
function saveAsFile(fileName, byte64) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = 'data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,' + byte64;
    document.body.appendChild(link);
    link.click();
    document.body.remove(link);
}