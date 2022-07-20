function [Map] = GetMapOfParams(names, values)
if isempty(names) || isempty(values)
    Map=containers.Map;
else
    Map = containers.Map(names, values);
end
end