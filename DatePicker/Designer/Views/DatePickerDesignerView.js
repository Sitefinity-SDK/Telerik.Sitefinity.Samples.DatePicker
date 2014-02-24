Type.registerNamespace("DatePicker.Designer.Views");

DatePicker.DatePickerDesignerView = function (element) {
    DatePicker.DatePickerDesignerView.initializeBase(this, [element]);
    this._minimumPicker = null;
    this._maximumPicker = null;
}

DatePicker.DatePickerDesignerView.prototype = {
    initialize: function () {
        DatePicker.DatePickerDesignerView.callBaseMethod(this, 'initialize');
        this._minimumPicker.add_popupOpening(Function.createDelegate(this, this._resizeDialogHandler));
        this._maximumPicker.add_popupOpening(Function.createDelegate(this, this._resizeDialogHandler));
    },

    dispose: function () {
        if (this._resizeDialogHandler) {
            this._minimumPicker._onPopupButtonKeyPressDelegate = null;
            delete this._loadDelegate;
        }
        DatePicker.DatePickerDesignerView.callBaseMethod(this, 'dispose');
    },

    //properties
    get_minimumPicker: function () { return this._minimumPicker; },
    set_minimumPicker: function (value) { this._minimumPicker = value },
    get_maximumPicker: function () { return this._maximumPicker; },
    set_maximumPicker: function (value) { this._maximumPicker = value },

    // implementation of IDesignerViewControl: Forces the control to refersh from the control Data
    refreshUI: function () {
        var controlData = this.get_controlData();
        if (controlData.Maximum != null && controlData.Minimum != null) {
            var maximumSplit = Sys.Serialization.JavaScriptSerializer.deserialize(controlData.Maximum).split("/");
            var year = maximumSplit[2];
            var month = maximumSplit[0] - 1;
            var day = maximumSplit[1];
            var maxDate = new Date(year, month, day);
            this._maximumPicker.set_selectedDate(maxDate);

            var minimumSplit = Sys.Serialization.JavaScriptSerializer.deserialize(controlData.Minimum).split("/");
            year = minimumSplit[2];
            month = minimumSplit[0] - 1;
            day = minimumSplit[1];
            var minDate = new Date(year, month, day);
            this._minimumPicker.set_selectedDate(minDate);
        }
    },

    // implementation of IDesignerViewControl: forces the designer view to apply the changes on UI to the control Data
    applyChanges: function () {
        var controlData = this.get_controlData();
        var maximumDate = (new Date(this._maximumPicker.get_selectedDate())).format("MM/dd/yyyy");
        var minimumDate = (new Date(this._minimumPicker.get_selectedDate())).format("MM/dd/yyyy");

        controlData.Maximum = Sys.Serialization.JavaScriptSerializer.serialize(GetUserPreferences().sitefinityToUniversalDate(maximumDate));
        controlData.Minimum = Sys.Serialization.JavaScriptSerializer.serialize(GetUserPreferences().sitefinityToUniversalDate(minimumDate));
    },

    // gets the javascript control object that is being designed
    get_controlData: function () {
        return this.get_parentDesigner().get_propertyEditor().get_control();
    },
    get_parentDesigner: function () {
        return this._parentDesigner;
    },

    // IDesignerViewControl: sets the reference fo the propertyEditor control
    set_parentDesigner: function (value) {
        this._parentDesigner = value;
    },

    /* --------------------  events handlers ----------- */

    _resizeDialogHandler: function (sender, args) {
        dialogBase.setWndHeight(340);
    },
}

DatePicker.DatePickerDesignerView.registerClass('DatePicker.Designer.Views.DatePickerDesignerView', Sys.UI.Control, Telerik.Sitefinity.Web.UI.ControlDesign.IDesignerViewControl);
