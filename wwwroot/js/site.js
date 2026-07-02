// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
setTimeout(function () {
	$('.alert').fadeOut('slow', function () {
		$(this).alert('close');
	});
}, 5000);

function confirmarExclusao(id, cliente) {
    Swal.fire({
        title: 'Tem a certeza?',
        text: 'Deseja excluir o aluguer de ' + cliente + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Sim, excluir!',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = '/Alugueres/Excluir?id=' + id;
        }
    });
}