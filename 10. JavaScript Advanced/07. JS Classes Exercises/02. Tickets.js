function getSortedTickets(ticketsArgs, sortingCriteria) {
    
    class Ticket {
        constructor (destination, price, status) {
            this.destination = destination
            this.price = price
            this.status = status
        }
    
        toString() {
            return `Ticket { destination: ${this.destination}
                        price: ${this.price.toFixed(2)}
                        status: ${this.status}}`
        }
    }

    let tickets = []

    for (let argument of ticketsArgs) {
        let [destination, price, status] = argument.split('|')
        let currentTicket = new Ticket(destination, Number(price), status)
        tickets.push(currentTicket)
    }

    tickets.sort((a, b) => {
        let result
        switch (sortingCriteria) {
            case 'destination':
                result = a.destination.localeCompare(b.destination)
                break;
            case 'price':
                result = a.price - b.price
                break;    
            case 'status':
                result = a.status.localeCompare(b.status)
                break;
        }

        return result
    })

    return tickets
}

console.log(getSortedTickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'status'
).toString())