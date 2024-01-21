var dataTable;

$(document).ready(function () { loadDataTable(); });

function loadDataTable()
{
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title',"width": "20%" },
            { data: 'productFeatures', "width": "30%" },
            { data: 'aoS', "width": "5%" },
            { data: 'listPrice', "width": "5%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/product/upsert?id=${data}" class="btn btn-success mx-2"> <i class="bi bi-pencil-square"></i> Düzenle </a>
                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-1"> <i class="bi bi-trash"></i> Sil</a>
                    </div >`
                },
                "width": "22%"
            },

        ]
    });
}


function Delete(id) {
    const url = `https://localhost:7167/Admin/Product/Delete/${id}`;
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
                type: 'GET',
                success: function (data) {
                    console.log(data);
                    toastr.success(data.message);
                }
            })
        }
    });
}

