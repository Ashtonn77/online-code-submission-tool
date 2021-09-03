let editor;

var htmlCode;
var cssCode;
var jsCode;

var frame;

function start() {

    htmlCode = document.getElementById("htmlCode").value;
    cssCode = "<style>" + document.getElementById("cssCode").value + "</style>";
    jsCode = "<scri" + "pt>" + document.getElementById("jsCode").value + "</scri" + "pt>";

    frame = document.getElementById("preview-window").contentWindow.document;

}

function changeFrame() {


    frame.open();
    frame.write(htmlCode + cssCode + jsCode);
    frame.close();

}


function showEditor() {

    editor = ace.edit("editor");
    editor.setTheme("ace/theme/monokai");
    editor.session.setMode("ace/mode/python");

}

function changeLanguage() {

    let language = $("#languages").val();
   
    if (language == "cpp") {
        editor.session.setMode("ace/mode/c_cpp");
    }

    else if (language == "csharp") {
        editor.session.setMode("ace/mode/csharp");
    }

    else if (language == "python") {
        editor.session.setMode("ace/mode/python");
    }

    else if (language == "sql") {
        editor.session.setMode("ace/mode/sql");
    }
         

}

function getCode() {

    var code = editor.getSession().getValue();
    
    return code;

}


