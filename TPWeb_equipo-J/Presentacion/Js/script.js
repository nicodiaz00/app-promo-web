


window.mostrarPopup = function () {
    
    document.getElementById("overlay").style.display = "flex";
    window.mostrarMensaje();
};

window.mostrarPopup2 = function () {
    document.getElementById("overlay").style.display = "flex";
    window.mostrarMensajeMail();
}

window.cerrarPopup = function () {
    
    document.getElementById("overlay").style.display = "none";
};

window.mostrarMensaje = function () {
    document.getElementById("mensaje").innerHTML = "Nombre, Apellido, Ciudad, <br> Codigo postal, Direccion, Email, son necesarios.<br>";
}
window.mostrarMensajeMail = function () {
    document.getElementById("mensaje").innerHTML = "El email debe tener formato valido<br> Ejemplo : usuario@dominio.com";
}
