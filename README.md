Ce wiki permet de recenser toutes les fonctionnalités et routes de l'API et a pour but d’être mis à jour ! 

## Présentation : 
Le projet CheckDesk est un projet réalisé dans le cadre d'un mastère en informatique à l'école d'ingénieur 3IL. Ce projet à pour but de permettre la configuration ainsi que le monitoring de différents parcs informatiques. 
CheckDesk est un projet comprenant 4 parties, toutes réalisé en dotnet : 

* **CheckDesk-API** : Partie central du projet, elle permet la centralisation des trois autres parties afin quelles communiques entre elle grace à la BDD.
* **CheckDesk-WEB** : Partie métier du projet, la partie web est l'application de gestion de l'ensemble du projet. Elle permet de configurer TOUT sur l'application. Réalisé avec Blazor server, nous pouvons également visualiser 
* **CheckDesk-Windows** : Application à deployer sur les ordinateurs à monitorer, elle permet la récolte des informations du desktop.

## Lancer l'API:
Tout d'abord, pour faire tourner le projet il faut le cloner depuis ce repository. 
Suite à ca il faut build le projet avec la commande : `dotnet build`

Aller dans les fichiers du projet, dans bin, puis executer le fichier d'execution .exe
