// Récupérer l'élément où afficher la date et l'heure
var dateHeureElement = document.getElementById("dateHeure");

dateHeureElement.style.fontFamily = 'Poppins, sans-serif';
dateHeureElement.style.textAlign = 'center';
dateHeureElement.style.fontSize = '24px';
dateHeureElement.style.color = '#fff';

// Fonction pour mettre à jour la date et l'heure
function mettreAJourDateHeure() {
    var maintenant = new Date();
    var options = { weekday: 'long', year: 'numeric', month: 'numeric', day: 'numeric', hour: 'numeric', minute: 'numeric', second: 'numeric', timeZoneName: 'short' };
    var dateHeureString = maintenant.toLocaleDateString('fr-FR', options);

    // Mettre à jour le contenu de l'élément
    dateHeureElement.textContent = dateHeureString;
}

// Appeler la fonction initiale
mettreAJourDateHeure();

// Mettre à jour la date et l'heure toutes les secondes
setInterval(mettreAJourDateHeure, 1000);
