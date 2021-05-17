$(function () {
    var l = abp.localization.getResource('JuanAlvarez');
    var createModal = new abp.ModalManager(abp.appPath + 'Empleados/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Empleados/EditModal');
    
    var DOWNLOAD_ENDPOINT = "/download";
    var downloadForm = $("form#DownloadFile");
    
    downloadForm.submit(function (event) {
        event.preventDefault();
        
        var fileName = $("#fileName").val().trim();
        
        var downloadWindow = window.open(
            
          DOWNLOAD_ENDPOINT + "/" + fileName,
          "_blank"  
        );
        
        downloadWindow.focus();
    })
    
    $("#UploadFileDto_File").change(function () {
       var fileName = $(this)[0].files[0].name;
       
       $("#UploadFileDto_Name").val(fileName);
    });

    var dataTable = $('#EmpleadosTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: true,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(nacho.juanAlvarez.empleados.empleado.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l('EmpleadoDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        nacho.juanalvarez.empleados.empleado
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }

                            ]
                    }
                },
                {
                    title: l('NombreApellido'),
                    data: "nombreApellido"
                },
                {
                    title: l('Mail'),
                    data: "mail"
                },
                {
                    title: l('Celular'),
                    data: "celular"
                },
                {
                    title: l('Pais'),
                    data: "pais"
                },
                {
                    title: l('Localidad'),
                    data: "localidad"
                },
                {
                    title: l('NroBusqueda'),
                    data: "nroBusqueda"
                },
                {
                    title: l('AreaPuesto'),
                    data: "areaPuesto"
                },
                {
                    title: l('FechaPostulacion'),
                    data: "fechaPostulacion",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('Postulacion'),
                    data: "postulacion"
                },
                {
                    title: l('RemPretendida'),
                    data: "remPretendida"
                },
                {
                    title: l('DisponibilidadViaje'),
                    data: "disponibilidadViaje",
                    render: function (data) {
                        return l('Enum:EmpleadoDisponibilidadViaje:' + data);
                    }
                },
                {
                    title: l('Estado'),
                    data: "estado",
                    render: function (data) {
                        return l('Enum:EmpleadoEstado:' + data);
                    }
                },
                {
                    title: l('Comentario'),
                    data: "comentario"
                },
                {
                    title: l('Valoracion'),
                    data: "valoracion",
                    render: function (data) {
                        return l('Enum:EmpleadoValoracion:' + data);
                    }
                }

            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewEmpleadoButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    function loadFilters(filter, columnIndex) {

        // Declare variables
        var table, tr, td, i, txtValue;

        table = document.getElementById("EmpleadosTable");
        tr = table.getElementsByTagName("tr");

        // Loop through all table rows, and hide those who don't match the search query
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName("td")[columnIndex];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter.toUpperCase()) > -1) {
                    tr[i].style.display = "";
                } else {
                    tr[i].style.display = "none";
                }
            }
        }
    }

    $("#paisFilter").on('keyup change', function () {
        loadFilters(this.value, 4);
    });

    $("#areaFilter").on('keyup change', function () {
        loadFilters(this.value, 7);
    });

    $("#nroBusquedaFilter").on('keyup change', function () {
        loadFilters(this.value, 6);
    });
});
