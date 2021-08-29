let editor;


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


