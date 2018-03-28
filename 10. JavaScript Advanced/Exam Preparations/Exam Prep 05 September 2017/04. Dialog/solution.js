class Dialog {
    constructor(message, callback) {
        this.message = message
        this.callback = callback
        this.inputs = []
        this.element = null
    }

    addInput(label, name, type) {
        this.inputs.push([label, name, type])
    }

    render() {
        this.element = this._compose()
        $(document.body).append(this.element)
    }

    _submit() {
        if (this.element === null) {
            return
        }

        let params = {}
        this.element.find('input').each((index, el) => {
            params[el.name] = el.value
        })

        this.element.remove()
        this.callback(params)
    }

    _cancel() {
        if (this.element === null) {
            return
        }

        this.element.remove()
    }

    _compose() {
        let overlayEl = $('<div class="overlay">')
        let dialog = $('<div class="dialog">')
        let p = $(`<p>${this.message}</p>`)
        dialog.append(p)

        for (const input of this.inputs) {
            dialog.append($(`<label>${input[0]}</label>`))
            dialog.append($(`<input name="${input[1]}" type="${input[2]}" />`))          
        }

        let okBtn = $(`<button>OK</button>`).click(this._submit.bind(this))
        let cancelBtn = $(`<button>Cancel</button>`).click(this._cancel.bind(this))
        dialog.append(okBtn)
        dialog.append(cancelBtn)
        overlayEl.append(dialog)

        return overlayEl
    }
}