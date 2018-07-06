
//Get all the Resources available 
function getResources() {
    return fetch("/api/Resources", { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter as Resources"));
            }
        });
}

//Get the Resource with the id ResourceID  
function getResources_RID(ResourceID) {

    x
    return fetch("/api/Resources/" + ResourceID , { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter o Resource"));
            }
        });
}
//Get all the Classes with the resourceFK equals to ResourceID  
function getClasses_Resource(ResourceID) {


    return fetch("/api/Resources/" + ResourceID + "/classes/", { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter as Classes respetivas ao Resource"));
            }
        });
}

//Get all the Classes with the resourceFK equals to ResourceID  

function getClasses() {


    return fetch("api/Classes", { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter as Classes"));
            }
        });
}

//Get all the info about a class
function getClasses_CID(classID) {


    return fetch("api/Classes/" + classID, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter a Classe"));
            }
        });
}