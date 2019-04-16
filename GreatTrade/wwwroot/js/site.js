// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/**
 * SWITCH
 * */
function showHide() {
    var checkBox = document.getElementById("check");
    var hiddenElements = document.getElementById("hidden");

    if (checkBox.checked) {
        hiddenElements.style.display = "block";
    } else {
        hiddenElements.style.display = "none";

    }

}

function imprimir() {
    var PName = document.getElementById("PName");
    var PCategory = getSelectedOption(document.getElementById("PCategory"));
    var PSubCategory = getSelectedOption(document.getElementById("PSubCategory"));
    var PDescription = CKEDITOR.instances['PDescription'].getData();
    var PTags = document.getElementById("PTags");

    alert(PName.value + " " + PCategory.value + " " + PSubCategory.value + " " + PDescription.value + " " + PTags.value)

}

function getSelectedOption(sel) {
    var opt;
    for (var i = 0, len = sel.options.length; i < len; i++) {
        opt = sel.options[i];
        if (opt.selected === true) {
            break;
        }
    }
    return opt;
}


/**
 * IMAGE GALERRY
 * */

var dropArea = document.getElementById("drop-area");

//dropArea.addEventListener('dragenter', highlight(), false)
//dropArea.addEventListener('dragleave', highlight(), false)
//dropArea.addEventListener('dragover', highlight(), false)
//dropArea.addEventListener('drop', highlight(), false)

//function highlight(e) {
//    dropArea.classList.add("highlight")
//}

//function unhighlight(e) {
//    dropArea.classList.remove("highlight");
//}


//dropArea.addEventListener("drop", handleDrop, false);

function handleDrop(e) {
    let dt = e.dataTransfer
    let files = dt.files

    handleFiles(files)
}

function handleFiles(files) {
    files = [...files]
    if (files.length < 6) {
        files.forEach(uploadFile)
        files.forEach(previewFile)
    }
    else {
        alert("Maximo 5 archivos");
    }
}


function uploadFile(file) {
    let url = 'https://localhost:44317/AddProduct'
    let formData = new FormData()

    formData.append('file', file)

    fetch(url, {
        method: 'POST',
        body: formData
    })
        .then(() => { /* Done. Inform the user */ })
        .catch(() => { /* Error. Inform the user */ })
}

function previewFile(file) {
    let reader = new FileReader()
    reader.readAsDataURL(file)
    reader.onloadend = function () {
        let img = document.createElement('img')
        img.src = reader.result
        document.getElementById('gallery').appendChild(img)
    }

}


