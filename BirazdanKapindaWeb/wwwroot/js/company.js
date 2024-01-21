var dataTable;

$(document).ready(function () { loadDataTable(); });

function loadDataTable()
{
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/company/getall' },
        "columns": [
            { data: 'name',"width": "20%" },
            { data: 'streetAdress', "width": "30%" },
            { data: 'city', "width": "5%" },
            { data: 'state', "width": "5%" },
            { data: 'phoneNumber', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/company/upsert?id=${data}" class="btn btn-success mx-2"> <i class="bi bi-pencil-square"></i> Düzenle </a>
                    <a onClick=Delete('/admin/company/delete/${data}') class="btn btn-danger mx-1"> <i class="bi bi-trash"></i> Sil</a>
                    </div >`
                },
                "width": "22%"
            },

        ]
    });
}

function Delete(id) {
    const url = `https://localhost:7167/Admin/Company/Delete/${id}`;
    Swal.fire({
        title: "Emin misiniz?",
        text: "Bu değişikliği geri alamayacaksınız!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Evet, sil!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'GET', // Eğer httpdelete attr ile işaretlenirse buradaki get-delete yapılması gereklidir. - BBeratgenc
                success: function (data) {
                    console.log(data);
                    toastr.success(data.message);
                }
            })
        }
    });
}

