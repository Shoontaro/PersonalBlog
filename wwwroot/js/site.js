// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function loadView(id) {
    try {
        // Вызываем метод контроллера (подставьте корректный путь, например /Home/GetDetailsPartial)
        const response = await fetch(`/Home/GetDetailsPartial?id=${id}`);

        if (!response.ok) {
            throw new Error('Ошибка загрузки данных');
        }

        // Получаем чистый HTML код
        const htmlContent = await response.text();

        // Вставляем HTML в контейнер
        document.getElementById('viewContainer').innerHTML = htmlContent;
    } catch (error) {
        console.error(error);
        document.getElementById('viewContainer').innerHTML = '<p class="text-danger">Не удалось загрузить данные.</p>';
    }
}
