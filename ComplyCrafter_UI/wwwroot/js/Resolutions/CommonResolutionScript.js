let frmAppointmentDetail = {
    appointedDirector: "",
    designation: "",
    numberOfYear: null,
    appointmentDate: null,
    retirementDate: null,
    appointedDirectorDIN: "",
    director1Approver: "",
    director2Approver: "",
    shareType: "",
    numberOfShares: null,
    serialNumberFromTo: "",
    dateOfConsent: null,
    placeOfConsent: "",
    incorporateAgendaInExistingMeeting: "",
    existingMeeting: "",
    authorizedSignatory: "",
    category: "",
    appointeeIs: "",
    dateOfPassingCircularResolution: null,
}

let frmAuthorizationDetail = {
    id: 0,
    appointedDirector: "",
}

let frmSubscriberDetail = {
    id: 0,
    subscriberName: "",
    folioNo: "",
    numberOfShare: 0,
}

let frmMeetingAgendaDetail = {
    agenda: "",
    agendaHeading: "",
    minuteHeading: "",
    agendaPreface: "",
    minutePreface: "",
    resolutionForNoticePara1: "",
    resolutionForNoticePara2: "",
    resolutionForMinutesPara1: "",
    resolutionForMinutesPara2: "",
    signingDirector1: "",
    signingDirector2: "",
    authorizedSignatory: "",
}

let frmMeetingResolutionForNoticeCertificateDetail = {
    id: 0,
    srNo: "",
    nameOfHolder: "",
    folioNo: "",
    certificateNo: "",
    distinctiveNoFrom: "",
    distinctiveNoTo: "",
    typeOfSecurities: "",
    noOfSecurities: 0,
    newCertificateNo: "",
}

let frmMeetingResolutionForMinutesCertificateDetail = {
    id: 0,
    srNo: "",
    nameOfHolder: "",
    folioNo: "",
    certificateNo: "",
    distinctiveNoFrom: "",
    distinctiveNoTo: "",
    typeOfSecurities: "",
    noOfSecurities: "",
    newCertificateNo: "",
}

let frmMeetingResolutionSignatureDetail = {
    id: 0,
    signingDirector: "",
    dinPan: "",
    signingDate: null,
}

let frmKMPDetail = {
    name: "",
    fatherName: "",
    pan: "",
    dateOfBirth: null,
    mobile: "",
    email: "",
    gender: "",
    addressLine1: "",
    addressLine2: "",
    state: "",
    city: "",
    pincode: 0,
    country: "",
}

let frmApprovalCertificateConsolidationDetail = {
    approvalMode: "",
    dateOfPassingCircularResolution: "",
    incorporateAgendaInExistingBoardMeeting: "",
    existingBoardMeeting: "",
    dateOfNewMeeting: "",
    timeOfNewMeeting: "",
    authorizedSignatory: "",
}

let frmMeetingPerticularsOfCertificatesDetail = {
    id: 0,
    typeOfShare: "",
    shareholder: "",
    dateOfIssue: null,
}

let frmDirectorDetail = {
    din: "",
    name: "",
    fatherName: "",
    gender: "",
    dateOfBirth: null,
    address: "",
    email: "",
    mobile: "",
    pan: "",
    country: "",
    occupation: "",
    dateOfAppointment: null,
    dateOfConsent: null,
    placeOfSigningConsent: "",
    applicantFromProfessionalInstitute: "",
    professionalInstituteName: "",
    membershipNo: "",
    certificatePracticeNo: "",
}

let frmMeetingInterestInOtherEntitiesDetail = {
    id: 0,
    cin: "",
    companyName: "",
    dateOfAppointment: null,
    designation: "",
    otherIfAny: "",
}

let _directorsAgenda = [];

let directorsOptionHTMLAgenda = '';

function setOriginalValues() {
    let allSelect = $('select, input:not([type="radio"]):not([type="checkbox"]):not([name="id"])')
    for (const element of allSelect) {
        $(element).val('');
    }
    $('input[type="radio"], input[type="checkbox"]').prop('checked', false);
    $('input[type="radio"], input[type="checkbox"]').trigger('change');
    if (typeof resetTableAuthorized !== 'undefined') {
        resetTableAuthorized();
    }
    resetTableCert();
    if (typeof resetTableSignatory !== 'undefined') {
        resetTableSignatory();
    }
    resetAgendasField();
    if (typeof resetTableSubscriber !== 'undefined') {
        resetTableSubscriber();
    }
    if (typeof resetParticularsOfCertificates !== 'undefined') {
        resetParticularsOfCertificates();
    }
    if (typeof resetInterestRow !== 'undefined') {
        resetInterestRow();
    }
}

async function loadDirectors() {
    let comp_id = localStorage.getItem("comp_id");
    _directorsAgenda = await $.get(`${R_ApiUrl}/Director/ByCompanyAddressDetails/${comp_id}`);
}

async function loadMeeting_AgendaDetails(functionCall, startIndexForTable) {
    setOriginalValues();
    let data = await $.get(`${R_ApiUrl}/MeetingAgendaDetail/GetByMeetingAndResoln/${meeting}/${resolnId}`);
    console.log(data);
    if (data.appointmentDetails) {
        functionCall(data.appointmentDetails, '.custom-table tbody');
    }
    if (data.authorizationDetails && data.authorizationDetails.length > 0) {
        for (let i = startIndexForTable; i < data.authorizationDetails.length; i++) {
            addAuthorizedRow()
        }
        $('.authorizedRow').each(function (index) {
            functionCall(data.authorizationDetails[index], this);
        });
    }
    if (data.meetingAgendaDetails) {
        functionCall(data.meetingAgendaDetails, '#frmAgenda');
    }
    if (data.meetingResolutionForNoticeCertificateDetails && data.meetingResolutionForNoticeCertificateDetails.length > 0) {
        for (let i = startIndexForTable; i < data.meetingResolutionForNoticeCertificateDetails.length; i++) {
            addRowCert('securitiesTable1');
        }
        $('#securitiesTable1 tr').each(function (index) {
            functionCall(data.meetingResolutionForNoticeCertificateDetails[index], this);
        });
    }
    else if(!isLayOut) {
        $('#securitiesTable1').closest("table").remove();
    }
    if (data.meetingResolutionForMinutesCertificateDetails && data.meetingResolutionForMinutesCertificateDetails.length > 0) {
        for (let i = startIndexForTable; i < data.meetingResolutionForMinutesCertificateDetails.length; i++) {
            addRowCert('securitiesTable2');
        }
        $('#securitiesTable2 tr').each(function (index) {
            functionCall(data.meetingResolutionForMinutesCertificateDetails[index], this);
        });
    }
    else if (!isLayOut) {
        $('#securitiesTable2').closest("table").remove();
    }
    if (data.meetingResolutionSignatureDetails && data.meetingResolutionSignatureDetails.length > 0) {
        for (let i = startIndexForTable; i < data.meetingResolutionSignatureDetails.length; i++) {
            addSignatoryRow();
        }
        $('#signatoryTable tbody tr').each(function (index) {
            functionCall(data.meetingResolutionSignatureDetails[index], this);
        });
    }
    if (data.meetingSubscriberDetails && data.meetingSubscriberDetails.length > 0) {
        for (let i = startIndexForTable; i < data.meetingSubscriberDetails.length; i++) {
            addSubscriber();
        }
        $('#subscriberTable tbody tr').each(function (index) {
            functionCall(data.meetingSubscriberDetails[index], this);
        });
    }
    if (data.meetingKMPDetails) {
        functionCall(data.meetingKMPDetails, '.custom-table-kmp tbody');
    }
    if (data.meetingApprovalCertificateConsolidationDetails) {
        functionCall(data.meetingApprovalCertificateConsolidationDetails, '.custom-section-approval-certificate-consolidation');
    }
    if (data.meetingPerticularsOfCertificatesDetails && data.meetingPerticularsOfCertificatesDetails.length > 0) {
        for (let i = startIndexForTable; i < data.meetingPerticularsOfCertificatesDetails.length; i++) {
            addParticularsOfCertificates();
        }
        $('#entriesContainer .rowContiner').each(function (index) {
            functionCall(data.meetingPerticularsOfCertificatesDetails[index], this);
        });
    }
    //To Do
    if (data.meetingDirectorDetails) {
        functionCall(data.meetingDirectorDetails, '.custom-director-detail');
    }
    if (data.meetingInterestInOtherEntitiesDetails && data.meetingInterestInOtherEntitiesDetails.length > 0) {
        for (let i = 0; i < data.meetingInterestInOtherEntitiesDetails.length; i++) {
            addInterestRow();
        }
        $('#interestTable tbody tr').each(function (index) {
            functionCall(data.meetingInterestInOtherEntitiesDetails[index], this);
        });
    }
}

async function SaveMeeting_AgendaDetail() {
    let data = {};
    data.appointmentDetails = getObj(frmAppointmentDetail, '.custom-table tbody');
    data.meetingAgendaDetails = getObj(frmMeetingAgendaDetail, '#frmAgenda');
    data.authorizationDetails = $.makeArray($('.authorizedRow')).map(d => getObj(frmAuthorizationDetail, d));
    data.meetingResolutionForNoticeCertificateDetails = $.makeArray($('#securitiesTable1 tr')).map(d => getObj(frmMeetingResolutionForNoticeCertificateDetail, d));
    data.meetingResolutionForMinutesCertificateDetails = $.makeArray($('#securitiesTable2 tr')).map(d => getObj(frmMeetingResolutionForMinutesCertificateDetail, d));
    data.meetingResolutionSignatureDetails = $.makeArray($('#signatoryTable tbody tr')).map(d => getObj(frmMeetingResolutionSignatureDetail, d));
    data.meetingSubscriberDetails = $.makeArray($('#subscriberTable tbody tr')).map(d => getObj(frmSubscriberDetail, d));
    data.meetingKMPDetails = getObj(frmKMPDetail, '.custom-table-kmp tbody');
    data.meetingApprovalCertificateConsolidationDetails = getObj(frmApprovalCertificateConsolidationDetail, '.custom-section-approval-certificate-consolidation');
    data.meetingPerticularsOfCertificatesDetails = $.makeArray($('#entriesContainer .rowContiner')).map(d => getObj(frmMeetingPerticularsOfCertificatesDetail, d));
    data.meetingDirectorDetails = getObj(frmDirectorDetail, '.custom-director-detail');
    data.meetingInterestInOtherEntitiesDetails = $.makeArray($('#interestTable tbody tr')).map(d => getObj(frmMeetingInterestInOtherEntitiesDetail, d));
    console.log(data);

    data.meetingId = meeting;
    data.resolutionId = resolnId;

    var x = await $._post(`${R_ApiUrl}/MeetingAgendaDetail`, data);
    if (x.status) {
        swal.fire({
            icon: 'success',
            title: 'Success!',
            text: "Resolution Saved Successfully."
        })
        //var resp = await saveImgPath(x.responseObject.id);
        //if (resp.status) {
        //    window.location = `@Url.Action("Meeting", "Home")/@ViewBag.type`
        //} else {
        //    swal.fire({
        //        icon: 'error',
        //        title: 'Error',
        //        text: "File not uploaded"
        //    })
        //}
    } else {
        swal.fire({
            icon: 'error',
            title: 'Error',
            text: x.message
        })
    }
}

function disableCustomTable() {
    $('.custom-table select').attr('disabled', true);
    $('.custom-table input').attr('disabled', true);
    $('.custom-table textarea').attr('disabled', true);
    $('.custom-table button').attr('disabled', true);
    $('.custom-table-subscriber select').attr('disabled', true);
    $('.custom-table-subscriber input').attr('disabled', true);
    $('.custom-table-subscriber textarea').attr('disabled', true);
    $('.custom-table-subscriber button').attr('disabled', true);
    $('.custom-table-kmp select').attr('disabled', true);
    $('.custom-table-kmp input').attr('disabled', true);
    $('.custom-table-kmp textarea').attr('disabled', true);
    $('.custom-table-kmp button').attr('disabled', true);
}

function disableAgendaForm() {
    $('#frmAgenda select').attr('disabled', true)
    $('#frmAgenda input').attr('disabled', true)
    $('#frmAgenda textarea').attr('disabled', true)
    $('#frmAgenda button').attr('disabled', true)
}

(async function () {
    await loadDirectors();
    directorsOptionHTMLAgenda = _directorsAgenda.map(d => `<option value="${d.din}">${d.firstName} ${d.middleName} ${d.lastName}</option>`).join('');
    $('select.director').append(directorsOptionHTMLAgenda);
    if (isLayOut) {
        await loadMeeting_AgendaDetails(setObj, 1);
    }
    else {
        await loadMeeting_AgendaDetails(setObjText, 0);
    }
    if (mode == 'view') {
        disableCustomTable();
        disableAgendaForm();
    }
})();