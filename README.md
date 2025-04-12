# Documentation 
## initialisation de dépot

```bash
git init
git remote add origin SSH_Repo
git status
git add README.md
git commit
git branch -M main
git push origin main
git log
git show
git restore --staged Readme.md /*permet de restorer au précédente étape*/
```

## Rédiger un commit
```
Titre de commentaire

Description de notre commit avec des informations sur l'évolution du projet
```

## création d'une branche

```bash
git checkout -b develop
```

Pour les bonnes pratiques on va integrer la notion de revue de code. pour cela on va créer une branche faire des modification, les envoyer sur le dépot distant, puis créer un pull request pour demander une revue de code .