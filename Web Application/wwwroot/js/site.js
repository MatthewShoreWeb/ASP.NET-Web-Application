// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function timeline() {
    let dates = document.querySelectorAll('.col-sm');
    for (let i = 0; i < dates.length; i++) {
        dates[i].addEventListener('mouseover', function () {
            console.log('hello');
        });
    }

        
}

try {
    if (window.location.href.includes('/Timeline')) {
        timeline();
    }
} catch (e) {
    console.log(e);
}