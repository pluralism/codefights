def bliny o
    s, m = [], o[0]
    1.upto(m) { |n| s << n }
    o.each { |x|
        (m + 1).upto(x) { |n| s << n } if s.last != x
        if s.last == x
            m = [x, m].max
            s.pop
        end   
    }
    s.empty?
end
