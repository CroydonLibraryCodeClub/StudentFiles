# A place for student files

This repository is intended to be cloned on each student machine. Each student can then have their own folder and have it cloned to every other machine at the library.

To see which local files have changed and need uploading, navigate to StudentFiles and enter:
```
git status
```

To commit files, you first need to track the changes. So if you want to track `StudentName/main.py` enter:
```
git add StudentName/main.py
```

Then commit:
```
git commit -m "new python file from StudentName"
```

Then push:
```
git push
```

To get changes from the server, enter:
```
git pull
```

