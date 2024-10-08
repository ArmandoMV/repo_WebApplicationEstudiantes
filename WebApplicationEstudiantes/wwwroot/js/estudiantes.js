document.addEventListener('DOMContentLoaded', function () {
    document.getElementById('loadStudentsButton').addEventListener('click', function () {
        document.getElementById('loadingMessage').style.display = 'block';
        document.getElementById('errorMessage').style.display = 'none'; 

        fetch('/api/estudiantes')
            .then(response => {
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                return response.json();
            })
            .then(data => {
                document.getElementById('loadingMessage').style.display = 'none';
                const studentList = document.getElementById('studentList');
                studentList.innerHTML = '';
                data.forEach(estudiante => {
                    studentList.innerHTML += `
                        <tr>
                            <td>${estudiante.nombre}</td>
                            <td>${estudiante.edad}</td>
                        </tr>
                    `;
                });
            })
            .catch(error => {
                document.getElementById('loadingMessage').style.display = 'none';
                document.getElementById('errorMessage').style.display = 'block';
                console.error('There was a problem with the fetch operation:', error);
            });
    });
});