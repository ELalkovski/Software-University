class PaymentProcessor {
    constructor(inputOptions) {
        this.payments = []
        this.options = {}
        this.setOptions(inputOptions)
    }

    getRequiredPayment(id) {
        let requiredElement
        for (const payment of this.payments) {
            if (payment.id === id) {
                requiredElement = payment
                break
            }
        }

        return requiredElement
    }

    setOptions(inputOptions) {
        if (!this.options.hasOwnProperty('types')) {
            this.options.types = ['service', 'product', 'other']
        }
        if (!this.options.hasOwnProperty('precision')) {
            this.options.precision = 2
        }
        if (inputOptions !== undefined) {
            if (inputOptions.hasOwnProperty('types')) {
                this.options.types = inputOptions.types
            }
            if (inputOptions.hasOwnProperty('precision')) {
                this.options.precision = inputOptions.precision
            }
        }
    }

    registerPayment(id, name, type, value) {
        if (id.length === 0 || typeof id !== 'string') {
            throw new Error('Id should not be empty string.')
        }
        if (name.length === 0 || typeof name !== 'string') {
            throw new Error('Name should not be empty string.')
        }
        if (value.length === 0 || typeof value !== 'number') {
            throw new Error('Value should be a valid number.')
        }

        if (!this.options['types'].includes(type)) {
            throw new Error('This type is not allowed.')
        }
        let existingPayment = this.getRequiredPayment(id)

        if (existingPayment !== undefined) {
            throw new Error('There is already registered payment with this id')
        }
        this.payments.push({ id, name, type, value })
    }

    deletePayment(id) {

        let requiredElement = this.getRequiredPayment(id)

        if (requiredElement === undefined) {
            throw new Error(`Element with id: ${id} does not found.`)
        }

        let indexToRemove = this.payments.indexOf(requiredElement)
        this.payments.splice(indexToRemove, 1)
    }

    get(id) {
        let requiredElement = this.getRequiredPayment(id)

        if (requiredElement === undefined) {
            throw new Error(`Element with id: ${id} does not found.`)
        }

        let result = `Details about payment ID: ${requiredElement.id}\n- Name: ${requiredElement.name}\n- Type: ${requiredElement.type}\n- Value: ${requiredElement.value.toFixed(this.options.precision)}`
        return result
    }

    toString() {
        let totalBalance = 0
        for (const payment of this.payments) {
            totalBalance += payment.value
        }
        let result = 'Summary:\n'
        result += `- Payments: ${this.payments.length}\n`
        result += `- Balance: ${totalBalance.toFixed(this.options.precision)}`
        return result
    }
}

// Initialize processor with default options
const generalPayments = new PaymentProcessor();
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
generalPayments.registerPayment('01A3', 'Biopolymer', 'product', 23000);
//console.log(generalPayments.toString());

// Should throw an error (invalid type)
//generalPayments.registerPayment('E028', 'Rare-earth elements', 'materials', 8000);

generalPayments.setOptions({ types: ['product', 'material'] });
generalPayments.registerPayment('E028', 'Rare-earth elements', 'material', 8000);
console.log(generalPayments.get('E028'));
generalPayments.registerPayment('CF15', 'Enzymes', 'material', 55000);

// Should throw an error (ID not found)
//generalPayments.deletePayment('E027');
// Should throw an error (ID not found)
//generalPayments.get('E027');

generalPayments.deletePayment('E028');
console.log(generalPayments.toString());

// Initialize processor with custom types
const servicePyaments = new PaymentProcessor({ types: ['service'] });
servicePyaments.registerPayment('01', 'HR Consultation', 'service', 3000);
servicePyaments.registerPayment('02', 'Discount', 'service', -1500);
console.log(servicePyaments.toString());

// Initialize processor with custom precision
const transactionLog = new PaymentProcessor({ precision: 5 });
transactionLog.registerPayment('b5af2d02-327e-4cbf', 'Interest', 'other', 0.00153);
console.log(transactionLog.toString());