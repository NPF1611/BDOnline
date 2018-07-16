document.addEventListener('DOMContentLoaded', function main() {

    init();

});

function init() {
    listResources();
    listClasses();


}



/**************************Resources************************/
function listResources() {
    return getResources()
        .then(function (resources) {
            showResources(resources);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function showResources(resources) {
    for (var i = 0; i < resources.length; i++) {

        res = resources[i];

        var divRes = document.getElementById("Resources");

        var divRolesd = document.createElement("div");
        //div that will contains the reference image to the resource
        var resourceName = document.createElement("h1");
        resourceName.setAttribute("class", "idResourceName");
        resourceName.textContent = res.Name;

        //setting the atribute to identify the id values
        divRolesd.setAttribute('class', "div-resourcesn1 ");
        resourceName.setAttribute('data-idRole', res.ID);


        divRolesd.setAttribute('data-idRole', res.ID);
        divRolesd.appendChild(resourceName);
        //*********************onclick********************************************
        divRolesd.onclick = SearchID => {
            var id = SearchID.target.getAttribute('data-idRole', res.ID);
            ResourcesToClasses();
            listSelectedHeroes(id);
        }

        divRes.appendChild(divRolesd);
    }
}


/**************************Classes************************/
function listClasses() {
    return getClasses()
        .then(function (classes) {
            showClasses(classes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function showClasses(classes) {
    for (var i = 0; i < classes.length; i++) {
        classe = classes[i];

        var divClass = document.getElementById("Classes");

        var divContainer = document.createElement("div");
        divContainer.setAttribute('class', 'div-Classes');
        divContainer.setAttribute('data-ClassID', classe.ID);
        //----------img--------------
        var img_class = document.createElement("img")
        img_class.setAttribute('class', 'ClassImgs');
        img_class.setAttribute('data-ClassID', classe.ID);

        img_class.src = classe.Ch_Symbol;

        //----------Name--------------
        var divClassName = document.createElement("div");
        divClassName.setAttribute('class', 'div-nome');
        divClassName.setAttribute('data-ClassID', classe.ID);

        var className = document.createElement("h1");
        className.classList.add("ClassNames");
        className.setAttribute('data-ClassID', classe.ID);
        className.textContent = classe.Name
        divClassName.appendChild(className);
        //append----------
        divContainer.appendChild(img_class);
        divContainer.appendChild(divClassName);

        divContainer.onclick = searchID => {
            var idC = searchID.target.getAttribute('data-ClassID', classe.ID);
            classeToDetails();
            listDetails(idC);

        }

        //
        divClass.appendChild(divContainer);

    }
}

/**************************interactions************************/

//set the style, changing theclasses
function ResourcesToClasses() {
    var ClassDiv = document.getElementById('Classes');
    var ResourcesSelected = document.getElementById('Resources');
    var Classelected = document.getElementById('selectedClasses');
    var DetailsDiv = document.getElementById('Details');


    Classelected.innerHTML = "";
    ClassDiv.classList.add("hide")
    Classelected.classList.remove("hide");
    DetailsDiv.classList.add("hide");
}

function classeToDetails() {
    var ClassDiv = document.getElementById('Classes');
    var ResourcesSelected = document.getElementById('Resources');
    var Classelected = document.getElementById('selectedClasses');
    var DetailsDiv = document.getElementById('Details');


    DetailsDiv.innerHTML = "";
    ClassDiv.classList.add("hide")
    Classelected.classList.add("hide");
    ResourcesSelected.classList.add("hide");
    DetailsDiv.classList.remove("hide");
}

function Back() {
    var ClassDiv = document.getElementById('Classes');
    var ResourcesSelected = document.getElementById('Resources');
    var Classelected = document.getElementById('selectedClasses');
    var DetailsDiv = document.getElementById('Details');


    DetailsDiv.innerHTML = "";
    ClassDiv.classList.remove("hide");
    ResourcesSelected.classList.remove("hide");
    Classelected.classList.add("hide");
    DetailsDiv.classList.add("hide");

}



/************************** classes based on the resource selected************************/
function listSelectedHeroes(id) {
    return getClasses_Resource(id)
        .then(function (classes) {
            showSelectedClasses(classes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function showSelectedClasses(classes) {
    for (var i = 0; i < classes.length; i++) {

        classe = classes[i];

        var divCont = document.getElementById("selectedClasses");

        var divContainer = document.createElement("div");
        divContainer.setAttribute('class', 'div-Classes');
        divContainer.setAttribute('data-ClassID', classe.ID);
        //----------img--------------
        var img_class = document.createElement("img")
        img_class.setAttribute('class', 'ClassImgs');
        img_class.src = classe.Ch_Symbol;
        img_class.setAttribute("data-ClassID", classe.ID)

        //----------Name--------------
        var divClassName = document.createElement("div");
        divClassName.setAttribute('class', 'div-nome');
        divClassName.setAttribute('data-ClassID', classe.ID);

        var className = document.createElement("h1");
        className.textContent = classe.Name;
        divClassName.appendChild(className);
        className.setAttribute('data-ClassID', classe.ID);

        className.classList.add("ClassNames");

        divContainer.appendChild(img_class);
        divContainer.appendChild(divClassName);

        divContainer.onclick = searchID => {
            var idC = searchID.target.getAttribute('data-ClassID', classe.ID);
            classeToDetails();
            listDetails(idC);

        }


        divCont.appendChild(divContainer);
    }
}

/************************** class Details************************/

function listDetails(id) {
    return getClasses_CID(id)
        .then(function (classDetails) {
            showClassDetails(classDetails);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function showClassDetails(classDetails) {

    classe = classDetails;

    var divCont = document.getElementById("Details");
    var divE = document.createElement("div");
    divE.setAttribute("class", "divEsquerda_view");
    if (classe.ID == 10) {
        divE.classList.remove("classOtherDE");
        divE.classList.add("classWarriorDE");
    } else {
        divE.classList.add("classOtherDE");
        divE.classList.remove("classWarriorDE");
    }
    //name div
    var divContentor = document.createElement("div");
    divContentor.setAttribute("class", "Cont");
    var title = document.createElement("h1");
    title.setAttribute("class", "title_view_f")
    title.classList.add("text")
    title.textContent = classe.Name;
    var symbol = document.createElement('img');
    symbol.setAttribute("class", "classImg_Symbol");
    symbol.src = classe.Ch_Symbol;
    divContentor.appendChild(symbol);
    divContentor.appendChild(title);
    divE.appendChild(divContentor);


    //description div
    var descDiv = document.createElement("div");
    var descTitle = document.createElement("h2");
    descTitle.textContent = "Description";
    var desc = document.createElement("p");
    desc.textContent = classe.Description;
    descDiv.appendChild(descTitle);
    descDiv.appendChild(desc);
    divE.appendChild(descDiv);
    //append all to the left div
    divE.appendChild(descDiv);
    //div da direita
    var divD = document.createElement("div");
    divD.setAttribute("class", "divDireita_view");

    var divImg = document.createElement("div");
    var img_D = document.createElement("img");
    img_D.setAttribute("class", "img_D");
    img_D.classList.add("classe" + classe.ID);
    img_D.src = classe.Ch_image_fullBody;
    divImg.appendChild(img_D);

    //divD.appendChild(divT2);
    divD.appendChild(divImg);

    divCont.appendChild(divE);
    divCont.appendChild(divD);





}