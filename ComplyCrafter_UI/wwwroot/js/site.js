const rgMobile = /^\d{9,10}$/gm
const rgEmail = /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/gm
const rgRegNo = /^([A-Z]{2}\d{1,2}[A-Z]{1,2}\d{4}|\d{1,2}[A-Z]{2}\d{4}[A-Z]{1,2})$/gm

const amountFormatter = new Intl.NumberFormat("en-IN", { style: "currency", currency: "INR" });
const amount = num => amountFormatter.format(parseFloat(num)).replace('₹', '₹ ');

$.fn.validateInput = function (isValid, msg = '') {
    if (isValid) $(this).removeClass('is-invalid');
    else {
        if (!$(this).hasClass('is-invalid')) $(this).addClass('is-invalid');
        $(this).closest('.form-group').find('.invalid-feedback').text(msg);
    }
}


const setRowContent = o => btoa(escape(JSON.stringify(o)));

const getRowContent = ctrl => JSON.parse(unescape(atob($(ctrl).closest('tr').find('.rowData').html().trim())));

const getObj = (objTmpl, ctrl = 'body') => {
    ctrl = $(ctrl);
    var obj = Object.assign({}, objTmpl);
    Object.keys(obj).forEach(k => {
        if (!$(ctrl).find(`[name="${k}"]`).length) return;
        if ($(ctrl).find(`[name="${k}"]`).hasClass('num dec')) { obj[k] = parseFloat($(ctrl).find(`[name="${k}"]`).val()); return; }
        if ($(ctrl).find(`[name="${k}"]`).hasClass('num')) { obj[k] = parseInt($(ctrl).find(`[name="${k}"]`).val()); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'checkbox') { obj[k] = $(ctrl).find(`[name="${k}"]`).is(':checked'); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'radio') { obj[k] = $(ctrl).find(`[name="${k}"]:checked`).val(); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'date') { obj[k] = new Date($(ctrl).find(`[name="${k}"]`).val()) || null; return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'time') { obj[k] = $(ctrl).find(`[name="${k}"]`).val() || null; return; }
        obj[k] = $(ctrl).find(`[name="${k}"]`).val();
    });
    return obj;
}

const setObj = (obj, ctrl = 'body') => {
    Object.keys(obj).forEach(k => {
        if (obj[k] == undefined || obj[k] == null) return;
        if (!$(ctrl).find(`[name="${k}"]`).length) return;
        if ($(ctrl).find(`[name="${k}"]`).hasClass('s2')) return;
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'checkbox') { $(ctrl).find(`[name="${k}"]`).prop('checked', obj[k]).trigger('change'); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'radio') { $(ctrl).find(`[name="${k}"][value="${obj[k]}"]`).prop('checked', true).trigger('change'); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'date' && obj[k]) { $(ctrl).find(`[name="${k}"]`).val(moment(obj[k]).format('YYYY-MM-DD')); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'file' && obj[k]) { return; }
        $(ctrl).find(`[name="${k}"]`).val(obj[k]).trigger('change');
    });
}

const setObjText = (obj, ctrl = 'body') => {
    Object.keys(obj).forEach(k => {
        if (!$(ctrl).find(`[name="${k}"]`).length) return;
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'date' && obj[k]) { $(ctrl).find(`[name="${k}"]`).text(moment(obj[k]).format("DD/MM/YYYY")); return; }
        if ($(ctrl).find(`[name="${k}"]`)) { $(ctrl).find(`[name="${k}"]`).text(obj[k]); return; }
    });
}

const setObjView = (obj, ctrl = 'body', nullReplacement = '') => {
    Object.keys(obj).forEach(k => {
        if (!$(ctrl).find(`[name="${k}"]`).length) return;
        if ($(ctrl).find(`[name="${k}"]`).hasClass('amount')) { $(ctrl).find(`[name="${k}"]`).text(obj[k].toFixed(2)); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'date' && obj[k]) { $(ctrl).find(`[name="${k}"]`).text(moment(obj[k]).format('DD-MMM-YYYY')); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'yesno' && obj[k]) { $(ctrl).find(`[name="${k}"]`).text(obj[k] ? 'Yes' : 'No'); return; }
        if ($(ctrl).find(`[name="${k}"]`).attr('type') == 'amount' && obj[k]) { $(ctrl).find(`[name="${k}"]`).text(amount(obj[k])); return; }
        $(ctrl).find(`[name="${k}"]`).text(obj[k] || nullReplacement).trigger('change');
    });
}

$._get = (url) => $.get(url);
$._post = (url, data = {}) => $.ajax({ url: url, type: 'POST', contentType: 'application/json', data: JSON.stringify(data) });
$._put = (url, data = {}) => $.ajax({ url: url, type: 'PUT', contentType: 'application/json', data: JSON.stringify(data) });

const toBase64 = file => new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => resolve(reader.result);
    reader.onerror = reject;
});

$.fn.FileB64 = function () {
    if (this.files.length) return toBase64(this.files[0]);
    else return new Promise((res, rej) => rej('No Files selected'));
}

const getLocal = (k) => JSON.parse(atob(localStorage.getItem(k) || 'e30='));
const setLocal = (k, o) => localStorage.setItem(k, btoa(JSON.stringify(o)));

Array.prototype.distinct = function () {
    function onlyUnique(value, index, array) {
        return array.indexOf(value) === index;
    }

    return this.filter(onlyUnique);
}

if ($.validator) {
    $.validator.methods.ctext = function (v, e) { return this.optional(e) || /^[A-Za-z\s]+$/.test(v) };
    $.validator.messages.ctext = 'Please enter a valid value.';
    $.validator.methods.mobile = function (v, e) { return this.optional(e) || /^\d{10}$/.test(v) };
    $.validator.messages.mobile = 'Please enter a valid mobile number.';
    $.validator.methods.pincode = function (v, e) { return this.optional(e) || /^\d{6}$/.test(v) };
    $.validator.messages.pincode = 'Please enter a valid pincode.';
    $.validator.setDefaults({
        errorElement: "div",
        errorPlacement: function (error, element) {
            error.addClass("invalid-feedback");

            if (element.prop("type") === "checkbox") {
                error.insertAfter(element.parent("label"));
            } else {
                $(element).parent().append(error);
                // error.insertAfter(element);
            }
        },
        highlight: function (element, errorClass, validClass) {
            $(element).addClass("is-invalid").removeClass("is-valid");
        },
        unhighlight: function (element, errorClass, validClass) {
            $(element).addClass("is-valid").removeClass("is-invalid");
            if (!$(element).val())
                $(element).removeClass("is-valid");
        },
    });
}

function price_in_words(price) {
    var sglDigit = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"],
        dblDigit = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"],
        tensPlace = ["", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"],
        handle_tens = function (dgt, prevDgt) {
            return 0 == dgt ? "" : " " + (1 == dgt ? dblDigit[prevDgt] : tensPlace[dgt])
        },
        handle_utlc = function (dgt, nxtDgt, denom) {
            return (0 != dgt && 1 != nxtDgt ? " " + sglDigit[dgt] : "") + (0 != nxtDgt || dgt > 0 ? " " + denom : "")
        };

    var str = "",
        digitIdx = 0,
        digit = 0,
        nxtDigit = 0,
        words = [];
    if (price += "", isNaN(parseInt(price))) str = "";
    else if (parseInt(price) > 0 && price.length <= 10) {
        for (digitIdx = price.length - 1; digitIdx >= 0; digitIdx--) switch (digit = price[digitIdx] - 0, nxtDigit = digitIdx > 0 ? price[digitIdx - 1] - 0 : 0, price.length - digitIdx - 1) {
            case 0:
                words.push(handle_utlc(digit, nxtDigit, ""));
                break;
            case 1:
                words.push(handle_tens(digit, price[digitIdx + 1]));
                break;
            case 2:
                words.push(0 != digit ? " " + sglDigit[digit] + " Hundred" + (0 != price[digitIdx + 1] && 0 != price[digitIdx + 2] ? " and" : "") : "");
                break;
            case 3:
                words.push(handle_utlc(digit, nxtDigit, "Thousand"));
                break;
            case 4:
                words.push(handle_tens(digit, price[digitIdx + 1]));
                break;
            case 5:
                words.push(handle_utlc(digit, nxtDigit, "Lakh"));
                break;
            case 6:
                words.push(handle_tens(digit, price[digitIdx + 1]));
                break;
            case 7:
                words.push(handle_utlc(digit, nxtDigit, "Crore"));
                break;
            case 8:
                words.push(handle_tens(digit, price[digitIdx + 1]));
                break;
            case 9:
                words.push(0 != digit ? " " + sglDigit[digit] + " Hundred" + (0 != price[digitIdx + 1] || 0 != price[digitIdx + 2] ? " and" : " Crore") : "")
        }
        str = [...words.reverse(), " Rupees"].join("")
    } else str = "";
    return str

}