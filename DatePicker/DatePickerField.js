Type.registerNamespace("DatePicker");

DatePicker.DatePickerField = function (element) {
    DatePicker.DatePickerField.initializeBase(this, [element]);
    this._datepicker = null;
}

DatePicker.DatePickerField.prototype = {
    initialize: function () {
        DatePicker.DatePickerField.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        DatePicker.DatePickerField.callBaseMethod(this, 'dispose');
    },
    // properties
    get_datepicker: function () { return this._datepicker; },
    set_datepicker: function (value) { this._datepicker = value; },

    get_value: function () {
        var date_picker = this.get_datepicker();
        var result = null;
        if (date_picker)
            result = date_picker.get_selectedDate();
        return result;
    },

    set_value: function (value) {
        var date_picker = this.get_datepicker();
        if (date_picker) date_picker.set_selectedDate(value);
    }
}

DatePicker.DatePickerField.registerClass('DatePicker.DatePickerField', Telerik.Sitefinity.Web.UI.Fields.FieldControl);
