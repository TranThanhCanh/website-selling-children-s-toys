
$(document).ready(function () {
    $.ajax({
        method: 'GET',
        url: '~/api/TestAPI',
        success: function (res) {
            $.each(res, function (index, item) {
                var rowHTML = '<tr>'
                    + '<td>' + item.MASP + '</td>'
                    + '<td>' + item.TENSP + '</td>'
                    + '<td>' + item.HINHANH + '</td>'
                    + '<td>' + item.DONGIA + '</td>'
                    + '<td>' + item.CHITIET + '</td>'
                    + '<td>' + item.MASP + '</td>'
                    + '<td>' + item.MALOAI + '</td>'
                    + '<td>' + item.MACL + '</td>'
                    + '<td>' + item.MATH + '</td>'
                    + '<td>' + item.MATUOI + '</td>'
                    + '</tr>';

                $('.tbl-sp tbody').append(rowHTML);
            });

        }
    });
    })