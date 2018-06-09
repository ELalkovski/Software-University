let salesService = (() => {

     function getActiveReceipt(userId) {
        return  requester.get('appdata', `receipts?query={"_acl.creator":"${userId}","active":true}`, 'kinvey')
    }

    function getReceiptEntries(receiptId) {
        return  requester.get('appdata', `entries?query={"receiptId":"${receiptId}"}`, 'kinvey')
    }

    async function addEntry(type, qty, price, receiptId) {
        let entryData = JSON.stringify({
            type,
            qty,
            price,
            receiptId
        })

        return await requester.post('appdata', 'entries', 'kinvey', entryData)
    }

    function deleteEntry(entryId) {
        return requester.remove('appdata', `entries/${entryId}`, 'kinvey')
    }

    async function checkoutReceipt(receiptId, productCount, total) {
        let active = false
        let receiptData = JSON.stringify({
            productCount,
            total,
            active
        })

        return await requester.update('appdata', `receipts/${receiptId}`, 'kinvey', receiptData)
    }

    function createReceipt() {
        let receiptData = JSON.stringify({
            total: 0,
            productCount: 0,
            active: true
        })

        return requester.post('appdata', 'receipts', 'kinvey', receiptData)
    }

    async function getMyReceipts(userId) {
        return await requester.get('appdata', `receipts?query={"_acl.creator":"${userId}","active":false}`, 'kinvey')
    }

    return {
        getActiveReceipt,
        getReceiptEntries,
        addEntry,
        deleteEntry,
        createReceipt,
        checkoutReceipt,
        getMyReceipts,
    }
})()