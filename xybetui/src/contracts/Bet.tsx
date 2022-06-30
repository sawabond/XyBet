import { BetResult } from "./BetResult"

export default interface Bet {
    id: number
    userId: number
    betSum: number
    result: BetResult
}