const  resCategory = {
    6: {
        title: "Appoint as Individual Director",
        fields: [
            { type: "din", name: "director", title: "Director" },
            { type: "string", name: "term", title: "Term" },
        ],
        obj: { director: '', term: '' }
    }
};

async function processResolution(id) {
    switch (id) {
        case 1:
        case 2:
            var r = await $._post(`${apiurl}/Action/ChangeOfficeAddress`, {
                id: 0,
                companyId: parseInt($('[name="companyId"]').val()),
                category: id == 1 ? 'withinLocalLimits' : 'outsideLocalLimits'
            });
            return r?.responseObject?.id;
        case 4:
            var r = await $._post(`${apiurl}/Action/DirectorAppointment`, {
                id: 0,
                companyId: parseInt($('[name="companyId"]').val()),
                category: id == 4 ? 'Additional Director' : ''
            });
            return r?.responseObject?.id;
        case 6:
            var r = await $._post(`${apiurl}/Action/General`, {
                id: 0,
                companyId: parseInt($('[name="companyId"]').val()),
                category: resCategory[id].title,
                content: JSON.stringify(resCategory[id].obj)
            });
            return r?.responseObject?.id;
    }
}



async function openResolution(ctrl) {
    var rd = getRowContent(ctrl);
    switch (rd.resolution) {
        case 1:
        case 2:
            var url = (baseUrl + '/Actions/Office/Change/Edit/' + rd.action).replace('//', '/')
            window.open(url, '_blank')
            break;
        case 4:
            var url = (baseUrl + '/Actions/Director/Appointment/Edit/' + rd.action).replace('//', '/')
            window.open(url, '_blank')
            break;
        case 6:
            console.log(rd);
            var r = await $.get(`${apiurl}/Action/General/${rd.action}`);
            openGeneralResolution(rd, r);
            
            break;
    }
}

async function openGeneralResolution(ro, obj) {
    var rd = resCategory[ro.resolution];
    $('#mdlGeneralResolution').find('.modal-title').text(rd.title)
    var html = ``;
    rd.fields.forEach(f => {
        switch (f.type) {
            case "string":
                html += `<div class="col-md-6 form-group"><label>${f.title}</label><input type="text" class="form-control" name="${f.name}" /></div>`
                break;
            case "din":
                html += `<div class="col-md-6 form-group"><label>${f.title}</label><select class="form-control director" name="${f.name}"></select></div>`
                break;
        }
    })
    $('#mdlGeneralResolution').find('.modal-body').html(`<div class="row">${html}</div>`)
    var r = await $.get(`${apiurl}/Director/ByCompany/${obj.companyId}`)
    $('#mdlGeneralResolution').find('.modal-body').find('select.director')
        .html(`<option value="" selected disabled></option>` + r.map(d => `<option value="${d.din}">${d.firstName} ${d.middleName} ${d.lastName}</option>`).join(''));

    $('#mdlGeneralResolution').find('.modal-body').attr('resolution', ro.resolution)
    $('#mdlGeneralResolution').find('.modal-body').data('action', setRowContent(obj));
    setObj(JSON.parse(obj.content), $('#mdlGeneralResolution').find('.modal-body'));

    $('#mdlGeneralResolution').modal('show');
}

function saveGeneralResolution() {
    var rd = JSON.parse(unescape(atob($('#mdlGeneralResolution').find('.modal-body').data('action').trim())))
    console.log(rd);
    rd.content = JSON.stringify(getObj(JSON.parse(rd.content), $('#mdlGeneralResolution').find('.modal-body')));
    $._post(`${apiurl}/Action/General`, rd).then(r => {
        if (r.status) {
            toastr.success('Saved Successfully');
            $('#mdlGeneralResolution').modal('hide');
        } else 
            toastr.error(r.message);
    });
}