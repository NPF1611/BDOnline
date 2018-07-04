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


        //div that will contains the reference image to the resource
        var resourceName = document.createElement("h1");
        resourceName.setAttribute("class", "idResourceName");
        resourceName.textContent = res.Name;

        //setting the atribute to identify the id values 
        resourceName.setAttribute('data-idRole', res.ID);
        //*********************onclick********************************************
        resourceName.onclick = SearchID => {
            var id = SearchID.target.getAttribute('data-idRole', res.ID);
            ResourcesToClasses();
            listSelectedHeroes(id);
        }

        divRes.appendChild(resourceName);
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
        //----------img--------------
        var img_class = document.createElement("img")
        img_class.setAttribute('class', 'ClassImgs');
        img_class.src = classe.Ch_Symbol;
        img_class.setAttribute("data-ClassID", classe.ID)

        //----------Name--------------
        var divClassName = document.createElement("div");
        divClassName.setAttribute('class', 'div-nome');
        var className = document.createElement("h1");
        className.classList.add("ClassNames")
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
        //----------img--------------
        var img_class = document.createElement("img")
        img_class.setAttribute('class', 'ClassImgs');
        img_class.src = classe.Ch_Symbol;
        img_class.setAttribute("data-ClassID", classe.ID)

        //----------Name--------------
        var divClassName = document.createElement("div");
        divClassName.setAttribute('class', 'div-nome');
        var className = document.createElement("h1");
        className.classList.add("ClassNames")
        className.textContent = classe.Name
        divClassName.appendChild(className);

        divContainer.onclick = searchID => {
            var idC = searchID.target.getAttribute('data-ClassID', classe.ID);
            classeToDetails();
            listDetails(idC);

        }

        divContainer.appendChild(img_class);
        divContainer.appendChild(divClassName);

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

    //name div 
    var divContentor = document.createElement("div");
    var title = document.createElement("h1");
    title.textContent = classe.Name;
    var symbol = document.createElement('img');
    symbol.src = classe.Ch_Symbol;
    divContentor.appendChild(symbol);
    divContentor.appendChild(title);

    divCont.appendChild(divContentor);
    //description div
    var descDiv = document.createElement("div");
    var descTitle = document.createElement("h2");
    descTitle.textContent = "Description";
    var desc = document.createElement("p");
    desc.textContent = classe.Description;
    descDiv.appendChild(descTitle);
    descDiv.appendChild(desc);

    //History div
    var divHist = document.createElement("div");
    var histTitle = document.createElement("h2");
    histTitle.textContent = "History";
    var hist = document.createElement("p");
    hist.textContent = classe.History;
    divHist.appendChild(histTitle);
    divHist.appendChild(hist);

    //Play Style div
    var divPlay = document.createElement("div");
    var playTitle = document.createElement("h2");
    playTitle.textContent = "Play Style";
    var play = document.createElement("p");
    play.textContent = classe.History;
    divPlay.appendChild(histTitle);
    divPlay.appendChild(hist);

    //div da direita
    var divClass = document.createElement("div");

    var Name_Class = document.createElement("p");
    var fightStyle = document.createElement("p");
    var Ch_image_fullBody;
    var Weapon;
    var Secondary_weapon;
    var Ab_graph;
    var Aweking_weapon = document.createElement("p");











}