const users = {
    admin: '1234',
    gamer: 'pass'
};

function login() {
    const user = document.getElementById('username').value;
    const pass = document.getElementById('password').value;
    const error = document.getElementById('login-error');
  

    if (!user || !pass) {
        error.textContent = 'Kérjük, adja meg a felhasználónevet és jelszót!';
        return;
    }
    if (!users[user]) {
        error.textContent = 'Nem létező felhasználó!';
        return;
    }
    if (users[user] !== pass) {
        error.textContent = 'Helytelen jelszó!';
        return;
    }
    navigateTo("main_page.html")
}

function logout() {
   navigateTo("login.html")
}

function navigateTo(page) {
    window.location.href = page;
}

function toggleDetails(button) {
    const detail = button.nextElementSibling;
    detail.classList.toggle('hidden');
}

function gameForYou() {
    const container = document.querySelector('.games-for-you');
    // Előző ajánlás törlése
    const old = container.querySelector('.recommendation');
    if (old) old.remove();

    const div = document.createElement("div");
    div.className = "recommendation";
    const p = document.createElement("p");
    const img = document.createElement("img");
    const age = document.getElementById("age").value;
if(age !== ""){
    if (age > 1999) {
        p.textContent = "Neked a Fortnite-ot ajánljuk!";
        img.src = "Fortnite.jpg";
        img.alt = "Fortnite";
        img.id = "fortnite-sizing"
    } else {
        p.textContent = "Neked a Pongot ajánljuk";
        img.src = "Pong.png";
        img.alt = "Pong";
    }
    
}
else{
    p.textContent = "Adj meg egy helyes évszámot!"
    p.id = "valid-age"
}
div.appendChild(p);
    div.appendChild(img);
    container.appendChild(div);
}

function sortBy() {
    const filter = document.getElementById('filter').value;
    const products = document.querySelectorAll('#filtered-products .product');

    products.forEach(prod => {
        const platforms = prod.dataset.platforms.split(',');
        if (filter === 'all' || platforms.includes(filter)) {
            prod.style.display = 'block';
        } else {
            prod.style.display = 'none';
        }
    });
}
