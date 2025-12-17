

DOWNLOAD github windows edition

	URL
		https://git-scm.com/download/win

	SELECT 
		Git for Windows/x64 Setup

git init
git add .
git commit -m "Initial portfolio"

		Author identity unknown
		*** Please tell me who you are.

git config --global user.name "rebanawa10-lab"
git config --global user.email "rebanawa10@gmail.com"
git config --global --list

		RESULT:
		user.name=rebanawa10-lab
		user.email=rebanawa10@gmail.com

git commit -m "Initial portfolio"

		RESULT:
		[master (root-commit) cd0de79] Initial portfolio
		 1 file changed, 16 insertions(+)
		 create mode 100644 _04githubportfolio CHK.cs

git push -u origin main
	
		ERROR:
		error: src refspec main does not match any
		error: failed to push some refs to 'origin'
	
git status

		RESULT:
		On branch master
		Changes not staged for commit:
		  (use "git add <file>..." to update what will be committed)
		  (use "git restore <file>..." to discard changes in working directory)
				modified:   _04githubportfolio CHK.cs

		no changes added to commit (use "git add" and/or "git commit -a")


NOTE: Then you must commit first.

git add .
git commit -m "Initial portfolio"

		RESULT:
		[master 6c30c0f] Initial portfolio
		 1 file changed, 44 insertions(+)
 
 
git branch
		Step 2: Check Your Current Branch
		
		RESULT:
		* main
	
git branch -M main
		Step 3: If Branch Is master, Rename to main
		
git remote -v
		Step 4: Make Sure Remote Exists

git remote remove origin
		error: remote origin already exists.
git remote -v		
git remote add origin https://github.com/rebanawa10-lab/angular-portfolio.git

	
git push -u origin main

git add .
git add "_04githubportfolio CHK.cs"
git commit -m "Initial portfolio"
git push -u origin main

-- BROWSER 
	Load github
	create repository -> angular-portfolio
	
	RESULT:
		echo "# angular-portfolio" >> README.md
		git init
		git add README.md
		git commit -m "first commit"
		git branch -M main
		git remote add origin https://github.com/rebanawa10-lab/angular-portfolio.git
		git push -u origin main


-- BROWSER VERIFY
	https://github.com/rebanawa10-lab/angular-portfolio.git

-- LAPTOP 	
	C:\Repos\Docker\04githubportfolio>	git remote remove origin
	C:\Repos\Docker\04githubportfolio>	git remote add origin https://github.com/rebanawa10-lab/angular-portfolio.git
	C:\Repos\Docker\04githubportfolio>	git remote -v
	C:\Repos\Docker\04githubportfolio>	git push -u origin main

-- FROM github to laptop


-- LAPTOP: 

	Data Github -> LAPTOP
		Option A (Easiest – keep GitHub version)
			git reset --hard origin/main
			git pull
			
		Option B (Keep your laptop changes)
			git add .
			git commit -m "Resolve merge conflicts"
			git pull origin main

-- LAPTOP:	

	Data LAPTOP -> Github 
		git status
		git add .
		git commit -m "Update portfolio from laptop"
		git push origin main

-- 9:37pm  Just updated the github desc, Laptop to pull the latest info here...
-- 9:47pm  updated laptop, push data to github



