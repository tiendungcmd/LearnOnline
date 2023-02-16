(function () {
    window.QuillFunctions = {
        createQuill: function (quillElement) {
            var options = {
                debug: 'info',
                modules: {
                    toolbar: [
                        [{ header: [1, 2, false] }],
                        ['bold', 'italic', 'underline'],
                        ['image', 'code-block']
                    ]
                },
                placeholder: 'Compose an epic...',
                readOnly: false,
                theme: 'snow'
            };

            // set quill at the object we can call
            // methods on later  
            new Quill(quillElement, options);
        },
        //createQuill1: function (quillElement) {
        //    var options = {
        //        debug: 'info',
        //        modules: {
                   
        //        },
        //        placeholder: 'Compose an epic...',
        //        readOnly: false,
        //        theme: 'snow'
        //    };

        getQuillHTML: function (quillControl) {
            return quillControl.__quill.root.innerHTML;
        },
        getQuillContent: function (quillControl) {
            return JSON.stringify(quillControl.__quill.getContents());
        },
        loadQuillContent: function (quillControl, quillContent) {
            content = JSON.parse(quillContent);
            return quillControl.__quill.setContents(content, 'api');
        },
        setContent: function (quillControl1, quillContent) {
            content = JSON.parse(quillContent);
            return quillControl1.__quill.setContents(content);
        },
        disableQuillEditor: function (quillControl) {
            quillControl.__quill.enable(false);
        },
        clear: function (quillControl) {
            content = JSON.parse("");
            return quillControl.__quill.setContents(content, 'api');
        }
    };
})();