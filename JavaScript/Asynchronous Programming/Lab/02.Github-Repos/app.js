async function loadRepos() {
	let inputUsername = document.getElementById('username');
	let reposResult = document.getElementById('repos');

	const data = await fetch(`https://api.github.com/users/${inputUsername.value}/repos`)
	const dataDeserilized = await data.json();

	dataDeserilized.forEach(element => {
		//console.log(element);

		const li = document.createElement('li');
		const a = document.createElement('a');
	

		a.innerHTML = element.full_name;
		a.href = element.html_url;

		li.appendChild(a);
		reposResult.appendChild(li);

	});

	
}