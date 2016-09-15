require 'json'

def aux(game, p = 1)
    v = []
    game.map { |n| 
        n.kind_of?(Array) ?  v << aux(n, !p) : v << n
    }
    p ? v.max : v.min
end


def HighestScore(g)
    aux(eval g)
end
