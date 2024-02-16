var dataTable;

$(document).ready(function () {
    var url = window.location.search;
    var status = "";

    if (url.includes("inprocess")) {
        status = "inprocess";
    }
    else if (url.includes("pending")) {
        status = "pending";
    }
    else if (url.includes("completed")) {
        status = "completed";
    }
    else if (url.includes("approved")) {
        status = "approved";
    }

    loadDataTable(status);
});

function loadDataTable(status) {
    dataTable = $('#tblData').DataTable({
        "destroy": true, // Destroy existing DataTable, if any
        "ajax": { url: '/admin/order/getall?status=' + status },
        "columns": [
            { data: 'orderHeaderId', "width": "5%" },
            { data: 'name', "width": "20%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'applicationUser.email', "width": "15%" },
            { data: 'orderStatus', "width": "10%" },
            { data: 'orderTotal', "width": "10%" },
            {
                data: 'orderHeaderId',
                "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                    <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i></a>
                    </div>`;
                },
                "width": "10%"
            }
        ]
    });
}
